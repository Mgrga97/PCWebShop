import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RouteNames } from "../../constants";
import { useEffect, useState } from "react";
import KorisniciService from "../../services/KorisniciService";


export default function KorisnikPromjena(){

const navigate = useNavigate();
const [korisnik,setKorisnik]=useState({});
const routeParams = useParams();

async function dohvatiKorisnika() {
    const odgovor = await KorisniciService.getBySifra(routeParams.sifra)
    setKategorija(odgovor)
}

useEffect(()=>{
    dohvatiKategoriju();
},[])


async function Promjena(korisnik) {
    const odgovor = await KorisniciService.Promjena(routeParams.sifra,korisnik);
    if(odgovor.greska){
        alert(odgovor.poruka)
        return
    }
    navigate(RouteNames.KORISNIK_PREGLED)
    
}


function odradiSubmit(e){ // e je event
e.preventDefault(); // nemoj napraviti zahtjev na server po standardnom načinu

let podaci = new FormData(e.target);

Promjena(
    
    
    {
    
        naziv: podaci.get('naziv')
    }

);
}
    return(

        <>
        Promjena korisnika


        <Form on onSubmit={odradiSubmit}>
            <Form.Group controlId="ime">
                <Form.Label>Ime</Form.Label>
                <Form.Control type="text" name="ime" required
                defaultValue={korisnik.ime}/>
            </Form.Group>
            <Form.Group controlId="prezime">
                <Form.Label>Prezme</Form.Label>
                <Form.Control type="text" name="prezime" required
                defaultValue={korisnik.prezime}/>
            </Form.Group>
            <Form.Group controlId="email">
                <Form.Label>Email</Form.Label>
                <Form.Control type="text" name="email" required
                defaultValue={korisnik.email}/>
            </Form.Group>


            <hr/>
            <Row>
            <Col xs={6} sm={6} md={6} lg={2} xl={6} xxl={6}>
            <Link 
            to={RouteNames.KATEGORIJE_PREGLED}
            className="btn btn-danger siroko"
            >Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={10} xl={6} xxl={6}>
            <Button variant="success" type="submit" className="siroko">
                Promjeni kategoriju
            </Button>
            </Col>
        </Row>


        </Form>
        
        </>
    )
}