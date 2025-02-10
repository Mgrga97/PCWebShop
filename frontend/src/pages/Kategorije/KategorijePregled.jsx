import { useEffect } from "react"
import KategorijeService from "../../services/KategorijeService"


export default function KategorijePregled(){

    async function DohvatiKategorije(){
        const odgovor = KategorijeService.get()
    }

    //hooks (kuka) se izvodi prilikom dolaska na stranicu Kategorije
    useEffect(()=>{
        DohvatiKategorije();
    },[])


    return(

        <>
        Ovdje će se vidjeti proizvodi iz baze
        </>
    )
}