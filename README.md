# HackerRankSolutions
Sample solutions to HackerRank problems (above medium difficulty level)

## Problems
### Maximum Difference in An Array
Given an array of integers a[], there should be a pair (i, j) that maximize a[i] - a[j] where i > j.<br />
Return value of maximized a[i] - a[j] (return -1 if the value is negative).
```
For example, given a = [2, 3, 10, 1], the result should be 10 - 2 = 8.
```

### Distinct Pairs
Given an array of integers a[], and target value k.<br />
In this array, find count of distinct pairs that sum to target value.
```
For example, given a = [1, 1, 2, 3] and k = 4.
There is only one distinct pair (1, 3) fulfilling the requirement.
The result should be 1.
```

### Sprint Training
Imagine there are n points along a straight trail, while a runner run sprints of intervals between those point.<br />
The training plan is an array a[], which implies the runner should run from point a[i] to point a[i+1].
```
For example, given n = 10, a = [2, 4, 1, 2].
The runner should run from point 2 to point 4,
then turn back from point 4 to point 1,
and then from point 1 to point 2.
```
Find the point that visited the most by runner after he finished training, i.e. in above example, point 2 is the most visited.<br />
If more than one point are visited the most, find the point with minimum index.

### Number of Paths in A Matrix
Imagine there is an m-by-n matrix (m rows, n columns), with element value to be either 0 or 1.<br />
There should be such a path, that start from the top left corner and end in the bottom right corner, with each step either move right or move down, and only pass by element with value 1.<br />
Find how many paths are there.
```
For example, given matrix
1 1 0 1
1 1 1 1,
there are 2 possible paths as elaborated by *
* * 0 1
1 * * *
and
* 1 0 1
* * * *
```
In above example, result should be 2.
