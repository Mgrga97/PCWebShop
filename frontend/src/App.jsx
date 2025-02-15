import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import Pocetna from './pages/Pocetna'
import KategorijePregled from './pages/Kategorije/KategorijePregled'
import KategorijaDodaj from './pages/Kategorije/KategorijaDodaj'
import KategorijePromjena from './pages/Kategorije/KategorijePromjena'


function App() {
  return (
    <>
      <Container>
        <NavBarEdunova />


        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna />} />
          <Route path={RouteNames.KATEGORIJE_PREGLED} element={<KategorijePregled/>} />
          <Route path={RouteNames.KATEGORIJA_NOVI} element={<KategorijaDodaj />} />
          <Route path={RouteNames.KATEGORIJA_PROMJENA} element={<KategorijePromjena />}/>
        </Routes>

          

        <hr />
        &copy; Pcwebshop 2025
      </Container>


    </>
  )
}

export default App
