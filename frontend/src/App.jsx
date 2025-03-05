import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import Pocetna from './pages/Pocetna'
import KategorijePregled from './pages/Kategorije/KategorijePregled'
import KategorijePromjena from './pages/Kategorije/KategorijePromjena'
import DodajKategoriju from './pages/Kategorije/DodajKategoriju'
import DodajKorisnika from './pages/Korisnici/DodajKorisnika'
import KorisnikPregled from './pages/Korisnici/KorisnikPregled'
import KorisnikPromjena from './pages/Korisnici/KorisnikPromjena'
import DodajProizvod from './pages/Proizvodi/DodajProizvod'
import ProizvodiPregled from './pages/Proizvodi/ProizvodiPregled'
import ProizvodiPromjena from './pages/Proizvodi/ProizvodiPromjena'


function App() {
  return (
    <>
      <Container>
        <NavBarEdunova />


        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna />} />
          <Route path={RouteNames.KATEGORIJE_PREGLED} element={<KategorijePregled/>} />
          <Route path={RouteNames.KATEGORIJA_NOVI} element={< DodajKategoriju />} />
          <Route path={RouteNames.KATEGORIJA_PROMJENA} element={<KategorijePromjena />}/>

          <Route path={RouteNames.KORISNIK_PREGLED} element={<KorisnikPregled/>} />
          <Route path={RouteNames.KORISNIK_NOVI} element={< DodajKorisnika />} />
          <Route path={RouteNames.KORISNIK_PROMJENA} element={<KorisnikPromjena />}/>
       
          <Route path={RouteNames.PROIZVOD_PREGLED} element={<ProizvodiPregled />} />
          <Route path={RouteNames.PROIZVOD_NOVI} element={<DodajProizvod />} />
          <Route path={RouteNames.PROIZVOD_PROMJENA} element={<ProizvodiPromjena />}/>
       
        </Routes>

          

        <hr />
        &copy; Pcwebshop 2025
      </Container>


    </>
  )
}

export default App
