import "./App.css";
import { Route, Switch } from "react-router-dom";
import MainNavigation from "./components/MainNavigation/MainNavigation";
import RateMovies from "./components/RateMovies/RateMovies";
import Home from "./components/Home/Home";

function App() {
  return (
    <div>
      <MainNavigation />
      <Switch>

        <Route path="/" exact>
          <Home />
        </Route>

        <Route path="/RateMovies">
          <RateMovies />
        </Route>

      </Switch>
    </div>
  );
}

export default App;
