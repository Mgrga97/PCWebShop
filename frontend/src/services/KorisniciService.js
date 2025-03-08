import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Korisnik')
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function getBySifra(sifra){
    return await HttpService.get('/Korisnik/' + sifra)
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function dodaj(Korisnik) {
    return HttpService.post('/Korisnik',Korisnik)
    .then(()=>{return {greska: false,poruka: 'Dodano'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod dodavanja'}})
}

async function Promjena(sifra,Korisnik) {
    return HttpService.put('/Korisnik/'+sifra,Korisnik)
    .then(()=>{return {greska: false,poruka: 'Promjenjeno'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod promjene'}})
}

async function obrisi(sifra) {
    return HttpService.delete('/Korisnik/'+sifra)
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