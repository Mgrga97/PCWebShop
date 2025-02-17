import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { useNavigate } from 'react-router-dom';
import { RouteNames } from '../constants';
import { NavbarCollapse, NavbarToggle } from 'react-bootstrap';



export default function NavBarEdunova(){

const navigate=useNavigate()


    return(
        <>
        <Navbar expand="lg" className="bg-body-tertiary">
            <Container>
                    <Navbar.Brand 
                    className='ruka'
                    onClick={()=>navigate(RouteNames.HOME)}
                    >Pcwebshop</Navbar.Brand>
                    <Navbar.Toggle aria-controls="basic-navbar-nav" />
                    <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="me-auto">
                        
                        <NavDropdown title="Izbornik" id="basic-nav-dropdown">
                        <NavDropdown.Item 
                        onClick={()=>navigate(RouteNames.KATEGORIJE_PREGLED)}
                        >Kategorije</NavDropdown.Item>
                        
                        <NavDropdown.Item 
                        onClick={()=>navigate(RouteNames.KATEGORIJE_PREGLED)}
                        >Korisnici</NavDropdown.Item>
                        
                        </NavDropdown>
                        <Nav.Link href='https://markogrgic-001-site1.ptempurl.com/swagger' target='_blank'>Swagger</Nav.Link>
                    </Nav>
                    </Navbar.Collapse>
            </Container>
        </Navbar>
        </>
    )
}