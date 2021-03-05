// * We want make a package of goal kilos of chocolate. We have small bars (1 kilo each) and big bars (5 
kilos each).
// * Return the number of small bars to use, assuming we always use big bars before small bars. Return -1 
if it can't be done.
// makeChocolate(4, 1, 9) → 4
// makeChocolate(4, 1, 10) → -1
// makeChocolate(4, 1, 7) → 2
// makeChocolate(6, 1, 12) → -1	
// makeChocolate(6, 1, 13) → -1
// makeChocolate(6, 2, 10) → 0
// makeChocolate(6, 2, 11) → 1	
// makeChocolate(6, 2, 12) → 2		
// makeChocolate(60, 100, 550) → 50	
// makeChocolate(1000, 1000000, 5000006) → 6

const makeChocolate = (small, big, goal) => {
  // if no bigs but enough smalls to cover goal
  if (big === 0 && small >= goal) {
    return goal; // we use all the smalls to cover goal
  }
    // when we have at least one big and the goal needs at least one big
    while (goal >= 5 && big >= 1) {
      big--; // consume a big
      goal = goal - 5; // reduce goal by 5
    }
    // if enough smalls to cover after exhausting bigs
    if (small >= goal) {
      return goal; // use all smalls to cover goal
    }

    else {
      return -1;
    }
}

console.log(makeChocolate(4, 1, 9));// * We want make a package of goal kilos of chocolate. We have small 
bars (1 kilo each) and big bars (5 kilos each).
// * Return the number of small bars to use, assuming we always use big bars before small bars. Return -1 
if it can't be done.
// makeChocolate(4, 1, 9) → 4
// makeChocolate(4, 1, 10) → -1
// makeChocolate(4, 1, 7) → 2
// makeChocolate(6, 1, 12) → -1	
// makeChocolate(6, 1, 13) → -1
// makeChocolate(6, 2, 10) → 0
// makeChocolate(6, 2, 11) → 1	
// makeChocolate(6, 2, 12) → 2		
// makeChocolate(60, 100, 550) → 50	
// makeChocolate(1000, 1000000, 5000006) → 6

const makeChocolate = (small, big, goal) => {
  // if no bigs but enough smalls to cover goal
  if (big === 0 && small >= goal) {
    return goal; // we use all the smalls to cover goal
  }
    // when we have at least one big and the goal needs at least one big
    while (goal >= 5 && big >= 1) {
      big--; // consume a big
      goal = goal - 5; // reduce goal by 5
    }
    // if enough smalls to cover after exhausting bigs
    if (small >= goal) {
      return goal; // use all smalls to cover goal
    }

    else {
      return -1;
    }
}

console.log(makeChocolate(4, 1, 9));
