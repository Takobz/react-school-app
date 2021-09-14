import React from 'react'
import { Navbar, Container } from 'react-bootstrap';

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
                <Navbar>Footer :)</Navbar>
            </Container>
        </Navbar>
    </div>
    )
}