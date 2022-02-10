import React from 'react';
import { Card } from 'react-bootstrap';

const SubjectCard= (props) =>
{
    var imgUrl = (props.imgUrl === "" || props.imgUrl === undefined) ?    
    "images/equation.jpg" : props.imgUrl;

    return(
        <Card style = {{ width:'18rem', height:'30rem'}}>
            <Card.Img src={ imgUrl }/>
            <Card.Body>
                <Card.Title>{props.name} : {props.shortname}</Card.Title>
                <Card.Text>
                    {props.description}
                </Card.Text>
            </Card.Body>
        </Card>
    );
}

export default SubjectCard;
