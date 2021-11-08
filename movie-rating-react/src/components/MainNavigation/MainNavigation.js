import React from 'react'
import { Navbar,Container,Nav } from 'react-bootstrap'
import  './MainNavigation.css'

function MainNavigation() {
  return (
    <div>
      <Navbar collapseOnSelect expand="lg" variant="light" className="bg-blue">
        <Container className="navbar-container">
          <Navbar.Toggle aria-controls="responsive-navbar-nav" />
          <Navbar.Collapse id="responsive-navbar-nav" className="navbar-tabs">
            <Nav className="me-auto navbar-nav-custom">
              <Nav.Link href="/" className="nav-title">Home</Nav.Link>
              <Nav.Link href="/RateMovies" className="nav-title">Rate Movies</Nav.Link>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
    </div>
  );
}

export default MainNavigation
