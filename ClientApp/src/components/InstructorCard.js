import React from 'react';
import {Card} from "react-bootstrap"

const InstructorCard = (props) => {

    var imgUrl = (props.imageUrl === "" || props.imageUrl === undefined) ?
                "images/account_img.png" : props.imageUrl

    return(
        <Card style = {{ width: '18rem', height: '30rem'}}>
            <Card.Img scr={imgUrl}/>
            <Card.Body>
                <Card.Title>{props.name} {props.surname}</Card.Title>
                <Card>
                    We put the will Bio over here!
                </Card>
            </Card.Body>
        </Card>
    );
}

export default InstructorCard;