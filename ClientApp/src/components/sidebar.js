import React from 'react'
import SideNav, { NavItem, NavIcon, NavText } from '@trendmicro/react-sidenav';
import '@trendmicro/react-sidenav/dist/react-sidenav.css';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom'
import * as icon from 'react-bootstrap-icons';
import CustomCard from './customCard'
import {Home} from './Home'

export default class SideBarNav extends React.Component
{

state = 
{
    expanded : false
}

render()
{
    const {expanded} = this.state;
    return(
        <Router>
            <Route render={({ location, history }) => (
                <React.Fragment>
                    <SideNav
                        onSelect={(selected) => {
                            const to = '/' + selected;
                            if (location.pathname !== to) {
                                history.push(to);
                            }
                        }}
                        onToggle={(expanded)=>{this.setState({expanded : expanded})}}
                    >
                        <SideNav.Toggle />
                        <SideNav.Nav defaultSelected="home">
                            <NavItem eventKey="home">
                                <NavIcon>
                                    <icon.HouseFill color="black" size="1.75em"/>
                                </NavIcon>
                                <NavText>
                                    Home
                                </NavText>
                            </NavItem>
                            <NavItem eventKey="subjects">
                                <NavIcon>
                                    <icon.BookHalf color="black" size="1.75em"/>
                                </NavIcon>
                                <NavText>
                                    Subjects
                                </NavText>
                            </NavItem>
                            <NavItem eventKey="instructors">
                                <NavIcon>
                                    <icon.PeopleFill color="black" size="1.75em"/>
                                </NavIcon>
                                <NavText>
                                    Instructors
                                </NavText>
                            </NavItem>
                        </SideNav.Nav>
                    </SideNav>
                    <Switch>
                        <Route path="/home">
                            <HomePage expanded={expanded}/>
                        </Route>
                        <Route path="/subjects">
                            <Subjects expanded={expanded}/>
                        </Route>
                        <Route path="/instructors">
                            <Instructors expanded={expanded}/>
                        </Route>
                    </Switch>
                </React.Fragment>
                
            )}
            />
        </Router>
    );
 }
}

function HomePage(props) 
{
    return(
    <div style = {{marginLeft: props.expanded ? 240 : 64}}>
      <h2>Home</h2>
      <Home></Home>
    </div>
    );
}

function Subjects(props) 
{
    return(
    <div style = {{marginLeft: props.expanded ? 240 : 64}}>
      <h2>Subjects</h2>
    </div>
    );
}

function Instructors(props)
{
    return(
    <div style = {{marginLeft: props.expanded ? 240 : 64}}>
      <h2>Instructors</h2>
    </div>
    );
}