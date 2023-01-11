import React, { Component } from 'react';
import { Container, Col } from 'react-bootstrap';
import Cards from './Cards.js';
import SideBar from './SideBar.js';
import Row from 'react-bootstrap/Row';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { tables: [], loading: true };
  }

  componentDidMount() {
    console.log("start did Mount");
    this.populateTableData();
    console.log("end did Mount");
  }

  renderTableList(tables)
  {
    return (<Row xs={1} md={2}>
        {tables.map((index, table) => 
          {
            <Cards
            name={table.name} />;
          }
        )}
        </Row>)
  }
  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : this.renderTableList(this.state.tables);

    return (
      <div>
      <Container fluid>
        <Row>
            <Col xs={2} id="sidebar-wrapper">      
              <SideBar />
            </Col>
            <Col  xs={10} id="page-content-wrapper">
                
       {/* <Row xs={1} md={2}>
        {["1", "2", "3", "4", "5"].map((index) => (
          <Cards 
          name={index+ " stalas"}
          />
        ))}
        <Cards name = "Baras"/>
        </Row> */}
        {contents}
        </Col> 
        </Row>
        </Container>
      </div>
    );
  }

  async populateTableData() {
    const response = await fetch('Table');
    const data = await response.json();
    this.setState({ tables: data, loading: false });
  }
}
