import React, { Component } from 'react';
import PostCard from './PostCard' 
import {Container, Row, Col} from 'react-bootstrap'

export class Home extends Component {

  constructor(props) 
  {
    super(props);
    this.state = {
      posts: [],
      loading: true,
    }
  }

  componentDidMount()
  {
    this.getAllPosts();
  }

  render(){
    let contents = this.state.loading 
      ? <p><em>Loading...</em></p>
      : Home.renderPostsCards(this.state.posts);

    return (
      <div>
         {contents}
      </div>
    );
  }

  static renderPostsCards(posts)
  {
    return(
      <Container>
        <Row className="show-grid">
          <Col lg={12}>
            <Row className="show-grid">
              {posts.map((post) =>
                <Col md={4} style={{ marginTop : 10, marginBottom: 10 }}>
                  <PostCard heading={post.heading} info={post.info}/>
                </Col>
              )}
            </Row>
          </Col>
        </Row>
      </Container>
    );
  }

  async getAllPosts()
  {
    var response = await fetch(`http://localhost:5000/api/posts/getAllPosts`,{
        method: 'GET',
        headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json'
        }
        });
    var data = await response.json();
    this.setState({ posts: data, loading : false });
  }
}
