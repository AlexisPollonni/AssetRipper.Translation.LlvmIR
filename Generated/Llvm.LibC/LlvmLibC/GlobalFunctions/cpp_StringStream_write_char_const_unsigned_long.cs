using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStream5writeEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::write(char const*, unsigned long)")]
internal static partial class cpp_StringStream_write_char_const_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* bytes, long size)
	{
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = cpp_span_char_size_const.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer);
			while ((ulong)((details_StringBufferWriterImpl*)@this)->index < (ulong)num2 && (ulong)num < (ulong)size)
			{
				sbyte b = ((sbyte*)bytes)[num];
				*(sbyte*)cpp_span_char_operator_unsigned_long_const.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer, ((details_StringBufferWriterImpl*)@this)->index) = b;
				num++;
				((details_StringBufferWriterImpl*)@this)->index++;
			}
			if ((ulong)num < (ulong)size)
			{
				((details_StringBufferWriterImpl*)@this)->out_of_range = 1;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
