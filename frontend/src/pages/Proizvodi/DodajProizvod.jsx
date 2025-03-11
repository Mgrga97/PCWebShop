import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import ProizvodiService from "../../services/ProizvodiService";
import KategorijeService from "../../services/KategorijeService";
import { useEffect, useState } from "react";


export default function DodajProizvod(){

    const navigate=useNavigate();

    const [kategorije, setKategorije] = useState([]);
  const [kategorijaSifra, setKategorijaSifra] = useState(0);

  async function dohvatiKategorije(){
    const odgovor = await KategorijeService.get();
    setKategorije(odgovor);
    setKategorijaSifra(odgovor[0].sifra);
  }

  useEffect(()=>{
    dohvatiKategorije();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  },[]);


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
    
        naziv: podaci.get('naziv'),
        kategorijaSifra: kategorijaSifra,
        cijena: parseFloat(podaci.get('cijena'))
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
                Dodaj proizvod
            </Button>
            </Col>
        </Row>


        </Form>
        
        </>
    )
}