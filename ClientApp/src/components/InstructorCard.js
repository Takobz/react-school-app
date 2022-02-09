import {Card} from "react-bootstrap"
import React from 'react';

const InstructorCard = (props) => {

    var imgUrl = (props.imageUrl === "" || props.imageUrl === undefined) ?
                "images/account_image.png" : props.imageUrl;

return(
    <Card style = {{width: '18rem', height: '30rem'}}>
        <Card.Img src={ imgUrl }/>
        <Card.Body>
            <Card.Title>{props.name} {props.surname}</Card.Title>
            <Card.Text>
                We will put the bio here!
            </Card.Text>
        </Card.Body>
    </Card>
    );
}

export default InstructorCard;