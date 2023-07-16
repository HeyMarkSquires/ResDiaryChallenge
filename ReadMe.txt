This solution splits a given list of numbers into a given number of pieces.
For example, an list of 1,2,3,4,5 with a given number of 3 will be split into 1,2 and 3,4 and 5.
On top of the main program, I have also included a test project that tests splitting various lists into various sizes.
Given that it was not discussed in the original specification, I have operated under the assumption that a list that is
being split into number of ways that's too high (For example, 1,2,3 being split 7 ways) or impossibly low (For example, the list is split 0 or -1 ways)
then the empty list will just be returned.

The code is best run using visual studio.