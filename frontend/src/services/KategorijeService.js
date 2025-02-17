import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Kategorije')
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function getBySifra(sifra){
    return await HttpService.get('/Kategorije/' + sifra)
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

async function Promjena(sifra,Kategorije) {
    return HttpService.put('/Kategorije/'+sifra,Kategorije)
    .then(()=>{return {greska: false,poruka: 'Promjenjeno'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod promjene'}})
}

async function obrisi(sifra) {
    return HttpService.delete('/Kategorije/'+sifra)
    .then(()=>{return {greska: false,poruka: 'Obrisano'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod brisanja'}})
}

export default {
    get,
    getBySifra,
    dodaj,
    Promjena,
    obrisi
}