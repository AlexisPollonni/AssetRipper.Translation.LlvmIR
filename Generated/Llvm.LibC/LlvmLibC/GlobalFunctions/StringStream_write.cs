using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStream5writeEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::write(char const*, unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("char const*")] void* bytes, [NativeType("unsigned long")] long size)
	{
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = span_char_size.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer);
			while ((ulong)((details_StringBufferWriterImpl*)@this)->index < (ulong)num2 && (ulong)num < (ulong)size)
			{
				sbyte b = ((sbyte*)bytes)[num];
				*(sbyte*)span_char_Index.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer, ((details_StringBufferWriterImpl*)@this)->index) = b;
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
