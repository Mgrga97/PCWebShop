import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Kategorije')
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function getBySifra(){
    return await HttpService.get('/Kategorije' + sifra)
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function dodaj(Kategorije) {
    return HttpService.post('/Kategorije',Kategorije)
    .then(()=>{return {greska: false,poruka: 'Dodano'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod dodavanja'}})
}

export default {
    get,
    getBySifra,
    dodaj
}