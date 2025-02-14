import { useEffect, useState } from "react"
import KategorijeService from "../../services/KategorijeService"
import { Button, Table } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function KategorijePregled(){

    const[kategorije,setKategorije] = useState();
    const navigate=useNavigate();

    async function DohvatiKategorije(){
        const odgovor = await KategorijeService.get()
        setKategorije(odgovor)
    }

    //hooks (kuka) se izvodi prilikom dolaska na stranicu Kategorije
    useEffect(()=>{
        DohvatiKategorije();
    },[])


    return(

        <>
        <Link
        to={RouteNames.KATEGORIJA_NOVI}
        className="btn btn-success siroko"
        >Dodaj novu kategoriju</Link>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Naziv</th>
                    <th>Akcija</th>
                </tr>
            </thead>
            <tbody>
                {kategorije && kategorije.map((kategorija,index)=>(
                    <tr key={index}>
                        <td>
                            {kategorija.naziv}
                        </td>
                        <td>
                            <Button
                            onClick={()=>navigate(`/Kategorije/${kategorija.sifra}`)}
                            >Promjena</Button>
                        </td>
                    </tr>
                
                ))}
            </tbody>
        </Table>
        </>
    )
}