import { Card } from "react-bootstrap";
import React from "react";

export default class CustomCard extends React.Component
{
    constructor(props)
    {
        super(props)
        this.state = {
            posts: [],
        }
        this.handleClick = this.handleClick.bind(this);
    }

    componentDidMount()
    {
        this.getAllPosts();
    }

    render(){
        return (
            <Card style = {{width: '18rem'}}>
                <Card.Img src="images/equation.jpg"/>
                <Card.Body>
                    <Card.Title>Theorem Of Pythagoras</Card.Title>
                    <Card.Text>
                        {this.props.post}
                    </Card.Text>
                </Card.Body>
            </Card>
    );}


    fetchAllPosts()
    {
        fetch(`http://localhost:5000/api/posts/getAllPosts`,{
        method: 'GET',
        headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json'
        }
         })
        .then(response => {
        return response.json();
        })
        .then(data => this.setState({ posts : data }))
        .catch(error => {
        console.error(error);
        });
    }
}

function fetchAllPosts()
{
    
}