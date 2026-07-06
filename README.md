# BMI Calculator (ASP.NET Core)

## Overview
A simple BMI calculator that takes Age, Gender, Height (cm), and Weight (kg) to compute BMI and classify health status.

## Setup
```bash
dotnet run
BMI Formula
BMI = Weight(kg) / Height(m)^2
Classification
    • Severe Thinness < 16
    • Moderate Thinness 16 - 17
    • Mild Thinness 17 - 18.5
    • Normal 18.5 - 25
    • Overweight 25 - 30
    • Obese Class I 30 - 35
    • Obese Class II 35 - 40
    • Obese Class III > 40
Docker Instructions
bash
# Build image
docker build -t bmi-calculator .

# Run container
docker run -d -p 5000:80 bmi-calculator

# Stop container
docker stop <container_id>

# Pull image
docker pull veerpalia/bmi-calculator