import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Kategorija')
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function getBySifra(sifra){
    return await HttpService.get('/Kategorija/' + sifra)
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function dodaj(Kategorije) {
    return HttpService.post('/Kategorija',Kategorije)
    .then(()=>{return {greska: false,poruka: 'Dodano'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod dodavanja'}})
}

async function Promjena(sifra,Kategorije) {
    return HttpService.put('/Kategorija/'+sifra,Kategorije)
    .then(()=>{return {greska: false,poruka: 'Promjenjeno'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod promjene'}})
}

async function obrisi(sifra) {
    return HttpService.delete('/Kategorija/'+sifra)
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