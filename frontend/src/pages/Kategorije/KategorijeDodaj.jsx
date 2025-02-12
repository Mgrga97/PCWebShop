import { Col, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function KategorijeDodaj(){


    return(

        <>
        Dodavanje kategorije
        <Row>
            <Col>
            <Link 
            to={RouteNames.KATEGORIJE_PREGLED}
            className="btn btn-danger siroko"
            >Odustani</Link>
            </Col>
        </Row>
        </>
    )
}