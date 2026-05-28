using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamC2ERKNS0_4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::StringStream(__llvm_libc_20_1_2_::cpp::span<char> const&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("buf")][NativeType("__llvm_libc_20_1_2_::cpp::span<char> const&")] Cpp_string_view* Buf)
	{
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&((Details_StringBufferWriterImpl*)This)->Buffer, Buf, 16L, isVolatile: false);
			((Details_StringBufferWriterImpl*)This)->Index = 0L;
			((Details_StringBufferWriterImpl*)This)->Out_of_range = 0;
		}
	}
}
