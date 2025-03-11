import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RouteNames } from "../../constants";
import { useEffect, useState } from "react";
import ProizvodiService from "../../services/ProizvodiService";


export default function ProizvodiPromjena(){

const navigate = useNavigate();
const [proizvod,setProizvod]=useState({});
const [kategorijaSifra, setKategorijaSifra] = useState(0);
const routeParams = useParams();

async function dohvatiProizvod() {
    const odgovor = await ProizvodiService.getBySifra(routeParams.sifra)
    if(odgovor.greska){
        alert(odgovor.poruka)
        return
    }
    let s = odgovor.poruka
    setProizvod(s)
    setKategorijaSifra(s.kategorijaSifra)
}

useEffect(()=>{
    dohvatiProizvod();
},[])


async function Promjena(proizvod) {
    const odgovor = await ProizvodiService.Promjena(routeParams.sifra,proizvod);
    if(odgovor.greska){
        alert(odgovor.poruka)
        return
    }
    navigate(RouteNames.PROIZVODI_PREGLED)
    
}


function odradiSubmit(e){ // e je event
e.preventDefault(); // nemoj napraviti zahtjev na server po standardnom načinu

let podaci = new FormData(e.target);

Promjena(
    
    
    {
    
        naziv: podaci.get('naziv'),
        kategorijaSifra:('kategorijaSifra'),
        cijena: parseFloat(podaci.get('cijena'))
    }

);
}
    return(

        <>
        Promjena proizvoda


        <Form on onSubmit={odradiSubmit}>
            <Form.Group controlId="naziv">
                <Form.Label>Naziv</Form.Label>
                <Form.Control type="text" name="naziv" required
                defaultValue={proizvod.naziv}/>
            </Form.Group>
            <Form.Group controlId="cijena">
                <Form.Label>Cijena</Form.Label>
                <Form.Control type="number" step={0.01} name="cijena"/>
            </Form.Group>
      
            <Form.Group className='mb-3' controlId='kategorija'>
            <Form.Label>Kategorija</Form.Label>
            <Form.Select 
            onChange={(e)=>{setKategorijaSifra(e.target.value)}}
            >
            {kategorije && kategorije.map((s,index)=>(
              <option key={index} value={s.sifra}>
                {s.naziv}
              </option>
            ))}
            </Form.Select>
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
                Promjeni proizvod
            </Button>
            </Col>
        </Row>


        </Form>
        
        </>
    )
}