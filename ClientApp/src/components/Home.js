import React, { Component } from 'react';
import CustomCard from './customCard' 
import {Container, Row, Col} from 'react-bootstrap'

export class Home extends Component {

  constructor(props) 
  {
    super(props);
    this.state = {
      posts: []
    }
  }

  ComponentDidMount()
  {
    this.getAllPosts();
  }

render(){
    return (
      <div>
        <Container>
          <Row className="show-grid">
            <Col lg={12}>
              <Row className="show-grid">
                <Col md={4} style={{ marginTop : 10, marginBottom: 10 }}>
                <CustomCard/>
                </Col>
                <Col md={4} style={{ marginTop : 10, marginBottom: 10 }}>
                  <CustomCard/>
                </Col>
                <Col md={4} style={{ marginTop : 10, marginBottom: 10 }}>
                  <CustomCard/>
                </Col>
                <Col md={4} style={{ marginTop : 10, marginBottom: 10 }}>
                  <CustomCard/>
                </Col>
              </Row>
            </Col>
          </Row>
        </Container>
      </div>
    );
  }

  getAllPosts()
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
