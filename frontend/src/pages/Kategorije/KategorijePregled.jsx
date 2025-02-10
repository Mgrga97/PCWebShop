import { useEffect, useState } from "react"
import KategorijeService from "../../services/KategorijeService"
import { Table } from "react-bootstrap";


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