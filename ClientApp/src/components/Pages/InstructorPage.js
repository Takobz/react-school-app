import React, {useEffect, useState} from 'react';
import InstructorCard from '../InstructorCard';
import {Container, Row, Col} from 'react-bootstrap'

const InstructorPage = (props) =>
{
    const [instructors, setInstructors] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {

    async function getAllInstructors()
    {
      var response = await fetch(`http://localhost:5000/api/instructor/getAll`, {
          method: 'GET',
          headers: {
              'Content-Type': 'application/json',
              'Accept': 'application/json'
          }
      });
      var data = await response.json();
      setInstructors(data);
      setLoading(false);
    }

    getAllInstructors();
  }, [instructors]);

    let contents = loading
    ? <p><em>Loading...</em></p>
    : renderInstructorCards(instructors);

    return(
        <div>
            {contents}
        </div>
    );

function renderInstructorCards(instructors) 
{
    return(
        <Container>
          <Row className="show-grid">
            <Col lg={12}>
              <Row className="show-grid">
                {instructors.map((instructor, i) =>
                  <Col md={4} style={{ marginTop : 10, marginBottom: 10 }} key={i}>
                    <InstructorCard name={instructor.name} surname={instructor.surname}/>
                  </Col>
                )}
              </Row>
            </Col>
          </Row>
        </Container>
      );
}

}


export default InstructorPage;