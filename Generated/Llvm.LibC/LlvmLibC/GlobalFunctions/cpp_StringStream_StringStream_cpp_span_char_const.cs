using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamC2ERKNS0_4spanIcEE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::StringStream(__llvm_libc_20_1_2_::cpp::span<char> const&)")]
internal static partial class cpp_StringStream_StringStream_cpp_span_char_const
{
	public unsafe static void Invoke(void* @this, void* buf)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer, buf, 16L, isVolatile: false);
			((details_StringBufferWriterImpl*)@this)->index = 0L;
			((details_StringBufferWriterImpl*)@this)->out_of_range = 0;
		}
	}
}
