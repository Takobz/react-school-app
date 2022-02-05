import { Card } from "react-bootstrap";
import React from "react";

export default class PostCard extends React.Component
{
    constructor(props)
    {
        super(props)
        this.state = {}
    }

    render(){
        return (
            <Card style = {{width: '18rem', height: '30rem'}}>
                <Card.Img src="images/equation.jpg"/>
                <Card.Body>
                    <Card.Title>{this.props.heading}</Card.Title>
                    <Card.Text>
                        {this.props.info}
                    </Card.Text>
                </Card.Body>
            </Card>
    );}
}