import { useEffect, useState } from "react"
import { Button, Table } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import ProizvodiService from "../../services/ProizvodiService";
import { NumericFormat } from "react-number-format";


export default function ProizvodiPregled(){

    const[proizvodi,setProizvodi] = useState([]);
    const navigate=useNavigate();

    async function DohvatiProizvod(){
        const odgovor = await ProizvodiService.get()
        setProizvodi(odgovor)
    }

    //hooks (kuka) se izvodi prilikom dolaska na stranicu Kategorije
    useEffect(()=>{
        DohvatiProizvod();
    },[])

    function obrisi(sifra){
if(!confirm('Sigurno obrisati')){
    return;
    }
brisanjeProizvoda(sifra);

    }

    async function brisanjeProizvoda(sifra) {
        const odgovor = await ProizvodiService.obrisi(sifra);
        if(odgovor.greska){
            alert(odgovor.poruka);
            return;
        }
        DohvatiProizvod();
    }


    return(

        <>
        <Link
        to={RouteNames.PROIZVOD_NOVI}
        className="btn btn-success siroko"
        >Dodaj novi proizvod</Link>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Naziv</th>
                    <th>Cijena</th>
                    <th>Kategorija</th>
                    <th>Akcija</th>
                </tr>
            </thead>
            <tbody>
                {proizvodi && proizvodi.map((proizvod,index)=>(
                    <tr key={index}>
                        <td>
                            {proizvod.naziv}
                        </td>
                        <td
                           className={proizvod.cijena==null ? 'sredina' : 'desno'}>
                            {proizvod.cijena==null ? 'Nije definirano' : 
                             <NumericFormat 
                             value={proizvod.cijena}
                             displayType={'text'}
                             thousandSeparator='.'
                             decimalSeparator=','
                             prefix={'€'}
                             decimalScale={2}
                             fixedDecimalScale
                             />
                             
                             }
                        </td>
                        
                        <td>
                            {proizvod.kategorijaNaziv}
                        </td>
                        <td>
                            <Button
                            onClick={()=>navigate(`/Proizvodi/${proizvod.sifra}`)}
                            >Promjena</Button>
                            &nbsp;&nbsp;&nbsp;
                            <Button
                            variant="danger"
                            onClick={()=>obrisi(proizvod.sifra)}
                            >Obriši</Button>

                        </td>
                    </tr>
                
                ))}
            </tbody>
        </Table>
        </>
    )
}