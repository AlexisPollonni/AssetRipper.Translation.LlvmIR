using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamC2ERKNS0_4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::StringStream(__llvm_libc_20_1_2_::cpp::span<char> const&)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::cpp::span<char> const&")] cpp_string_view* buf)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer, buf, 16L, isVolatile: false);
			((details_StringBufferWriterImpl*)@this)->index = 0L;
			((details_StringBufferWriterImpl*)@this)->out_of_range = 0;
		}
	}
}
