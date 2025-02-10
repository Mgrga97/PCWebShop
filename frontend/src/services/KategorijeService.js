import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Kategorije')
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}



export default {
    get
}