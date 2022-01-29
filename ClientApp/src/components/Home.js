import React, { Component , useEffect } from 'react';

export class Home extends Component {
  componentDidMount() 
  {
    getSomeData(1);
  }

  componentDidUpdate()
  {
    getSomeData(1);
  }

  render () {

    return (
      <div>
        
      </div>
    );
  }
}

async function getSomeData(postId) 
{
  await fetch('http://localhost:5000/api/posts/getPostById?postId=1', {
    //mode : 'no-cors',
    method : 'GET',
    headers: {
      'Content-Type': 'application/json',
      'Accept': 'application/json',
    }
  }).then(response => {
      return response.json();
    })
    .then(data => console.log("my data: " + data))
    .catch(error => {
      console.log("my err:" + error);
  });
}
