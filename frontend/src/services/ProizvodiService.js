import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Proizvod')
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function getBySifra(sifra){
    return await HttpService.get('/Proizvod/' + sifra)
    .then((odgovor)=>{
       // console.table(odgovor.data)
       return odgovor.data;
    })
    .catch((e)=>{})
}

async function dodaj(Proizvod) {
    return HttpService.post('/Proizvod',Proizvod)
    .then(()=>{return {greska: false,poruka: 'Dodano'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod dodavanja'}})
}

async function Promjena(sifra,Proizvod) {
    return HttpService.put('/Proizvod/'+sifra,Proizvod)
    .then(()=>{return {greska: false,poruka: 'Promjenjeno'}})
    .catch(()=>{return {greska: true,poruka: 'Problem kod promjene'}})
}

async function obrisi(sifra) {
    return HttpService.delete('/Proizvod/'+sifra)
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