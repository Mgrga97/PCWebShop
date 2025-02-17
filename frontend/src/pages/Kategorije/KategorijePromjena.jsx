import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RouteNames } from "../../constants";
import KategorijeService from "../../services/KategorijeService";
import { useEffect, useState } from "react";


export default function KategorijePromjena(){

const navigate = useNavigate();
const [kategorija,setKategorija]=useState({});
const routeParams = useParams();

async function dohvatiKategoriju() {
    const odgovor = await KategorijeService.getBySifra(routeParams.sifra)
    setKategorija(odgovor)
}

useEffect(()=>{
    dohvatiKategoriju();
},[])


async function Promjena(kategorija) {
    const odgovor = await KategorijeService.Promjena(routeParams.sifra,kategorija);
    if(odgovor.greska){
        alert(odgovor.poruka)
        return
    }
    navigate(RouteNames.KATEGORIJE_PREGLED)
    
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
        Promjena kategorije


        <Form on onSubmit={odradiSubmit}>
            <Form.Group controlId="naziv">
                <Form.Label>Naziv</Form.Label>
                <Form.Control type="text" name="naziv" required
                defaultValue={kategorija.naziv}/>
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