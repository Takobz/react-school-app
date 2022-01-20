import React, { Component } from 'react';
import { Header, Footer } from './components/EdgesOfPage';
import './custom.css'
import SideBarNav from './components/sidebar';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div className="App">
        <Header/>
        <SideBarNav/>
      </div>
    );
  }
}
