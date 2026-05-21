using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class MessageMapper_134ul_3113ul_get_str
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_13MessageMapperILm134ELm3113EE7get_strEi")]
	[DemangledName("__llvm_libc_20_1_2_::MessageMapper<134ul, 3113ul>::get_str(int) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_optional_bnt67x* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_MessageMapper_8a2hs7* This, [MangledName("num")] int Num)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			if (Num >= 0 && (ulong)Num < 134uL && ((int*)(&This->Msg_offsets))[Num] != -1)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)(&This->String_array) + ((int*)(&This->Msg_offsets))[Num]);
				Optional_cpp_string_view_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_cpp_string_view);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			}
			else
			{
				Llvm_memset_p0_i64.Invoke(Agg_result, 0, 24L, isVolatile: false);
				Optional_cpp_string_view_Constructor.Invoke(Agg_result);
			}
		}
	}
}
