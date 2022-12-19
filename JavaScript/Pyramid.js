"use strict";

const pyramid = (height) => {
  for (let i = 1; i <= height; i++) {
    const leadingSpaces = " ".repeat(height - i);
    const pyramidBody = "*".repeat(i * 2 - 1);
    console.log(`${leadingSpaces}${pyramidBody}`);
  }
};

console.clear();

pyramid(5);
