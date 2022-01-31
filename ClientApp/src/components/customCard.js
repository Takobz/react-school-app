import { Card } from "react-bootstrap";
import React from "react";

export default class CustomCard extends React.Component
{
    constructor(props)
    {
        super(props)
        this.state = {}
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick()
    {
        alert('card clicked!!');
    }

    render()
    {
        return (
            <Card style = {{width: '18rem'}}>
                <Card.Img src="images/equation.jpg"/>
                <Card.Body>
                    <Card.Title>Theorem Of Pythagoras</Card.Title>
                    <Card.Text>
                        If we have a right angled triangle. Then the following is true: r^2 = b^2 + c^2 Where a is the side opposite the right angle b and c are the two agent sides of the traingle.
                    </Card.Text>
                </Card.Body>
            </Card>
        );
    }
} 