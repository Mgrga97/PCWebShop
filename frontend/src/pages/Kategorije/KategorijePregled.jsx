import { useEffect, useState } from "react"
import KategorijeService from "../../services/KategorijeService"
import { Table } from "react-bootstrap";
import { Link } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function KategorijePregled(){

    const[kategorije,setKategorije] = useState();

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
                </tr>
            </thead>
            <tbody>
                {kategorije && kategorije.map((kategorija,index)=>(
                    <tr key={index}>
                        <td>
                            {kategorija.naziv}
                        </td>
                    </tr>
                
                ))}
            </tbody>
        </Table>
        </>
    )
}