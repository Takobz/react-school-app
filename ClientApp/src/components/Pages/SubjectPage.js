import React, { useState, useEffect } from 'react';
import  SubjectCard from '../SubjectCard';
import {Container, Row, Col} from 'react-bootstrap'

const SubjectPage = (props) => 
{
    const [subjects, setSubjects] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() =>{

     async function getAllSubjects()
     {
         var response = await fetch('http://localhost:5000/api/subjects/getall',{
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }});
            var data = await response.json();
            setSubjects(data);
            setLoading(false);
     }
     
     getAllSubjects();
    })

    let contents = loading
    ? <p><em>Loading...</em></p>
    : renderSubjectCards(subjects);

    return(
        <div>
            {contents}
        </div>
    );

    function renderSubjectCards(subjects)
    {
        return(
            <Container>
                <Row className="show-grid">
                <Col lg={12}>
                    <Row className="show-grid">
                        {subjects.map((subject, i) =>
                            <Col md={4} style={{ marginTop : 10, marginBottom: 10 }} key={i}>
                                <SubjectCard name={subject.name} shortname={subject.shortName} description={subject.description}/>
                            </Col>
                        )}
                    </Row>
                </Col>
                </Row>
            </Container>
        );
    }
}

export default SubjectPage