using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStream5writeEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::write(char const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("bytes")][NativeType("char const*")] void* Bytes, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		long num = 0L;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = Span_char_size.Invoke(&((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Buffer);
			while ((ulong)((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Index < (ulong)num2 && (ulong)num < (ulong)Size)
			{
				sbyte b = ((sbyte*)Bytes)[num];
				*(sbyte*)Span_char_Index.Invoke(&((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Buffer, ((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Index) = b;
				num++;
				((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Index++;
			}
			if ((ulong)num < (ulong)Size)
			{
				((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Out_of_range = 1;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
