import React, { Component } from 'react';
import * as Scroll from 'react-scroll'

export class Home extends Component {

  render () {

    getSomeData(1);
    
    return (
      <div>
        
      </div>
    );
  }
}

function getSomeData(postId) 
{
  fetch(`http://localhost:5000/api/posts/getPostById?postId=1`)
    .then(response => {
      if(!response.ok)
      {
        throw new Error(response.statusText);
      }
      console.log(response.json())
    }).catch(error => {
      console.log(error);
    });
}
