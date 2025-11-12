package org.neko;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class SolutionTest {
    @Test
    public void basicTests() {
        assertEquals("ababab", Solution.solve("3(ab)"));
        assertEquals("abbbabbb", Solution.solve("2(a3(b))"));
        assertEquals("bccbccbcc", Solution.solve("3(b(2(c)))"));
        assertEquals("kabaccbaccbacc", Solution.solve("k(a3(b(a2(c))))"));
    }
}