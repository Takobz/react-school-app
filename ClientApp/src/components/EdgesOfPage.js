import React from 'react'
import { Navbar, Container, Nav, Row, Col } from 'react-bootstrap';
import * as icon from 'react-bootstrap-icons';

export const Header = () => 
{
    return(
        <Navbar bg="primary" variant="dark">
            <Container>
                <Row className="mx-auto">
                    <Col>
                    <Navbar.Brand href="#home">
                        SchoolApp
                    </Navbar.Brand>
                    </Col>
                </Row>
            </Container>
        </Navbar>
    );
}

export const Footer = () => 
{
    return(
        <div className="fixed-bottom">
        <Navbar bg="primary" variant="dark">
            <Container>
                <Row className="mx-auto">
                    <Col className="mx-5">
                    <Nav.Link href="#home" >
                        <icon.HouseFill color="black" size={50}/>
                    </Nav.Link>
                    </Col>
                    <Col className="mx-5">
                    <Nav.Link href="#home">
                        <icon.BookHalf color="black" size={50}/>
                    </Nav.Link>
                    </Col>
                    <Col className="mx-5">
                    <Nav.Link href="#home" >
                        <icon.PeopleFill color="black" size={50}/>
                    </Nav.Link>
                    </Col>
                </Row>
            </Container>
        </Navbar>
    </div>
    )
}