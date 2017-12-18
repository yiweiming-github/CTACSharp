%module TapQuoteCppWrapper
%{
#include "TapAPICommDef.h"
#include "TapAPIError.h"
#include "TapQuoteAPIDataType.h"
#include "TapQuoteAPI.h"
%}

%typemap(imtype) TAPIUINT32 * "ref uint"
%typemap(cstype) TAPIUINT32 * "ref uint"
%typemap(csout) TAPIUINT32 * "out uint"
%typemap(imtype) TAPIUINT32 & "ref uint"
%typemap(cstype) TAPIUINT32 & "ref uint"

%typemap(imtype) TAPIINT32 * "ref int"
%typemap(cstype) TAPIINT32 * "ref int"
%typemap(csout) TAPIINT32 * "out int"
%typemap(imtype) TAPIINT32 & "ref int"
%typemap(cstype) TAPIINT32 & "ref int"

%typemap(imtype) TAPIINT64 * "ref long"
%typemap(cstype) TAPIINT64 * "ref long"
%typemap(csout) TAPIINT64 * "out long"
%typemap(imtype) TAPIINT64 & "ref long"
%typemap(cstype) TAPIINT64 & "ref long"

%typemap(imtype) TAPIUINT64 * "ref ulong"
%typemap(cstype) TAPIUINT64 * "ref ulong"
%typemap(csout) TAPIUINT64 * "out ulong"
%typemap(imtype) TAPIUINT64 & "ref ulong"
%typemap(cstype) TAPIUINT64 & "ref ulong"

%typemap(imtype) TAPIUINT16 * "ref ushort"
%typemap(cstype) TAPIUINT16 * "ref ushort"
%typemap(csout) TAPIUINT16 * "out ushort"
%typemap(imtype) TAPIUINT16 & "ref ushort"
%typemap(cstype) TAPIUINT16 & "ref ushort"

%typemap(imtype) TAPIUINT8 * "ref char"
%typemap(cstype) TAPIUINT8 * "ref char"
%typemap(csout) TAPIUINT8 * "out char"
%typemap(imtype) TAPIUINT8 & "ref char"
%typemap(cstype) TAPIUINT8 & "ref char"

%typemap(imtype) TAPIREAL64 * "ref double"
%typemap(cstype) TAPIREAL64 * "ref double"
%typemap(csout) TAPIREAL64 * "out double"
%typemap(imtype) TAPIREAL64 & "ref double"
%typemap(cstype) TAPIREAL64 & "ref double"

%include "TapAPICommDef.h"
%include "TapAPIError.h"
%include "TapQuoteAPIDataType.h"
%include "TapQuoteAPI.h"