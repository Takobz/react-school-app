import React from 'react'
import { Navbar, Container, Nav, Row, Col } from 'react-bootstrap';
import * as icon from 'react-bootstrap-icons';

export const Header = () => 
{
    return(
        <Navbar bg="primary" variant="dark">
            <Container>
                <Navbar.Brand href="#home">SchoolApp</Navbar.Brand>
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
                <Row>
                    <Col className=".ml-3">
                    <Nav.Link href="#home">
                        <icon.House color="black" size={50}/>
                    </Nav.Link>
                    </Col>
                    <Col className=".ml-3">
                    <Nav.Link href="#home" >
                        <icon.House color="black" size={50}/>
                    </Nav.Link>
                    </Col>
                </Row>
            </Container>
        </Navbar>
    </div>
    )
}