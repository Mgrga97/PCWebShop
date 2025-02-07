import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import Pocetna from './pages/Pocetna'
import ProizvodiPregled from './pages/Proizvodi/ProizvodiPregled'

function App() {
  return (
    <>
      <Container>
        <NavBarEdunova />


        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna />} />
          <Route path={RouteNames.KATEGORIJE_PREGLED} element={<ProizvodiPregled/>} />
        </Routes>

          

        <hr />
        &copy; Pcwebshop 2025
      </Container>


    </>
  )
}

export default App
