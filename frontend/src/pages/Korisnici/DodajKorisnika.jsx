import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import KorisniciService from "../../services/KorisniciService";


export default function DodajKorisnika(){

    const navigate=useNavigate();


async function Dodaj(korisnik) {
    const odgovor = await KorisniciService.dodaj(korisnik);
    if(odgovor.greska){
        alert(odgovor.poruka)
        return
    }
    navigate(RouteNames.KORISNIK_PREGLED)
}


function odradiSubmit(e){ // e je event
e.preventDefault(); // nemoj napraviti zahtjev na server po standardnom načinu

let podaci = new FormData(e.target);

Dodaj(
    
    
    {
    
        ime: podaci.get('ime'),
        prezime: podaci.get('prezime'),
        email: podaci.get('email'),
        lozinka: podaci.get('lozinka')
    }

);
}
    return(

        <>
        Dodavanje korisnika


        <Form on onSubmit={odradiSubmit}>
            <Form.Group controlId="ime">
                <Form.Label>ime</Form.Label>
                <Form.Control type="text" name="ime" required/>
            </Form.Group>
            <Form.Group controlId="prezime">
                <Form.Label>prezime</Form.Label>
                <Form.Control type="text" name="prezime" required/>
            </Form.Group>
            <Form.Group controlId="email">
                <Form.Label>email</Form.Label>
                <Form.Control type="text" name="email" required/>
            </Form.Group>
            <Form.Group controlId="lozinka">
                <Form.Label>lozinka</Form.Label>
                <Form.Control type="text" name="lozinka" required/>
            </Form.Group>


            <hr/>
            <Row>
            <Col xs={6} sm={6} md={6} lg={2} xl={6} xxl={6}>
            <Link 
            to={RouteNames.KORISNIK_PREGLED}
            className="btn btn-danger siroko"
            >Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={10} xl={6} xxl={6}>
            <Button variant="success" type="submit" className="siroko">
                Dodaj korisnika
            </Button>
            </Col>
        </Row>


        </Form>
        
        </>
    )
}