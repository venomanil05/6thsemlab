import { useState } from "react";
import "./App.css";

function App() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const [errors, setErrors] = useState({});

  const [message, setMessage] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();

    let newErrors = {};

    // Validate email
    if (email.trim() === "") {
      newErrors.email = "Email is required.";
    } else if (!email.includes("@")) {
      newErrors.email = "Enter a valid email.";
    }

    // Validate password
    if (password.trim() === "") {
      newErrors.password = "Password is required.";
    } else if (password.length < 6) {
      newErrors.password =
        "Password must be at least 6 characters.";
    }

    setErrors(newErrors);

    // If there are no errors
    if (Object.keys(newErrors).length === 0) {
      setMessage("Login successful!");
    } else {
      setMessage("");
    }
  };

  return (
    <div className="container">

      <div className="login-box">

        <h1>User Login</h1>

        <form onSubmit={handleSubmit}>

          <div className="form-group">
            <label>Email</label>

            <input
              type="text"
              placeholder="Enter your email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />

            {errors.email && (
              <p className="error">
                {errors.email}
              </p>
            )}
          </div>

          <div className="form-group">
            <label>Password</label>

            <input
              type="password"
              placeholder="Enter your password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />

            {errors.password && (
              <p className="error">
                {errors.password}
              </p>
            )}
          </div>

          <button type="submit">
            Login
          </button>

        </form>

        {message && (
          <p className="success">
            {message}
          </p>
        )}

      </div>

    </div>
  );
}

export default App;