import React, { Component } from 'react';
import CustomCard from './customCard' 

export class Home extends Component {

  constructor(props) 
  {
    super(props);
    this.state = {
      posts: []
    }
  }

  componentDidMount()
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

  componentDidUpdate()
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

render(){
    return (
      <div>
        <CustomCard/>
      </div>
    );
  }
}
