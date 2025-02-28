import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import ProizvodiService from "../../services/ProizvodiService";


export default function DodajProizvod(){

    const navigate=useNavigate();


async function Dodaj(proizvod) {
    const odgovor = await ProizvodiService.dodaj(proizvod);
    if(odgovor.greska){
        alert(odgovor.poruka)
        return
    }
    navigate(RouteNames.PROIZVODI_PREGLED)
}


function odradiSubmit(e){ // e je event
e.preventDefault(); // nemoj napraviti zahtjev na server po standardnom načinu

let podaci = new FormData(e.target);

Dodaj(
    
    
    {
    
        naziv: podaci.get('naziv')
    }

);
}
    return(

        <>
        Dodavanje proizvoda


        <Form on onSubmit={odradiSubmit}>
            <Form.Group controlId="naziv">
                <Form.Label>Naziv</Form.Label>
                <Form.Control type="text" name="naziv" required/>
            </Form.Group>


            <hr/>
            <Row>
            <Col xs={6} sm={6} md={6} lg={2} xl={6} xxl={6}>
            <Link 
            to={RouteNames.PROIZVODI_PREGLED}
            className="btn btn-danger siroko"
            >Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={10} xl={6} xxl={6}>
            <Button variant="success" type="submit" className="siroko">
                Dodaj proizvod
            </Button>
            </Col>
        </Row>


        </Form>
        
        </>
    )
}