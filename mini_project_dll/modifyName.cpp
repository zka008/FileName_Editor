#include "pch.h"
#include <string>
#include <sstream>

extern "C" {
    __declspec(dllexport) char* allocateString(const char* str) {
        char* buffer = new char[strlen(str) + 1];
        strcpy_s(buffer, strlen(str) + 1, str);
        return buffer;
    }

    __declspec(dllexport) void freeString(char* str) {
        delete[] str;
    }

    __declspec(dllexport) char* removeSubString(const char* str, int start, int end) {
        std::string tempStr(str);
        if (start >= 0 && start < tempStr.length()) {
            if (end > tempStr.length()) {
                end = tempStr.length();
            }
            tempStr.erase(start, end - start);
        }
        char* result = allocateString(tempStr.c_str());
        return result;
    }

    __declspec(dllexport) char* appendNumber(const char* str, int number, bool atFront) {
        std::string result;
        std::stringstream ss;
        if (atFront) {
            ss << number << "." << str;
        }
        else {
            ss << str << number;
        }
        result = ss.str();
        return allocateString(result.c_str());
    }
}
