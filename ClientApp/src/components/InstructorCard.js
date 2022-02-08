import React from 'react';
import {Card} from "react-bootstrap"

const InstructorCard = (props) => {

    var imgUrl = (props.imageUrl === "" || props.imageUrl === undefined) ?
                "images/account_image.png" : props.imageUrl

                console.log(props.imageUrl)

    return(
        <Card style = {{ width: '18rem', height: '30rem'}}>
            <Card.Img scr={imgUrl}/>
            <Card.Body>
                <Card.Title>{props.name} {props.surname}</Card.Title>
                <Card.Text>
                    We put the will Bio over here!
                </Card.Text>
            </Card.Body>
        </Card>
    );
}

export default InstructorCard;