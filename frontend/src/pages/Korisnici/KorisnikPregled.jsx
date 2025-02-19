import { useEffect, useState } from "react"
import { Button, Table } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import KorisniciService from "../../services/KorisniciService";



export default function KorisnikPregled(){

    const[korisnici,setKorisnik] = useState();
    const navigate=useNavigate();

    async function DohvatiKorisnika(){
        const odgovor = await KorisniciService.get()
        setKorisnik(odgovor)
    }

    //hooks (kuka) se izvodi prilikom dolaska na stranicu Korisnici
    useEffect(()=>{
        DohvatiKorisnika();
    },[])

    function obrisi(sifra){
if(!confirm('Sigurno obrisati')){
    return;
    }
brisanjeKorisnika(sifra);

    }

    async function brisanjeKorisnika(sifra) {
        const odgovor = await KorisniciService.obrisi(sifra);
        if(odgovor.greska){
            alert(odgovor.poruka);
            return;
        }
        DohvatiKorisnika();
    }


    return(

        <>
        <Link
        to={RouteNames.KORISNIK_NOVI}
        className="btn btn-success siroko"
        >Dodaj nove korisnike</Link>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Naziv</th>
                    <th>Akcija</th>
                </tr>
            </thead>
            <tbody>
                {korisnici && korisnici.map((korisnik,index)=>(
                    <tr key={index}>
                        <td>
                            {korisnik.ime}
                        </td>
                        <td>
                            <Button
                            onClick={()=>navigate(`/Korisnici/${korisnik.sifra}`)}
                            >Promjena</Button>
                            &nbsp;&nbsp;&nbsp;
                            <Button
                            variant="danger"
                            onClick={()=>obrisi(korisnik.sifra)}
                            >Obriši</Button>

                        </td>
                    </tr>
                
                ))}
            </tbody>
        </Table>
        </>
    )
}