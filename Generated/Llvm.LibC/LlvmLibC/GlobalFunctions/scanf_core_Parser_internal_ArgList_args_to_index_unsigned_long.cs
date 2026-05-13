using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE13args_to_indexEm")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::args_to_index(unsigned long)")]
internal static partial class scanf_core_Parser_internal_ArgList_args_to_index_unsigned_long
{
	public unsafe static void Invoke(scanf_core_Parser* @this, long index)
	{
		unchecked
		{
			if ((ulong)@this->args_index > (ulong)index)
			{
				@this->args_index = 1L;
				internal_ArgList_operator_internal_ArgList.Invoke(rhs: &@this->args_start, @this: &@this->args_cur);
			}
			while ((ulong)@this->args_index < (ulong)index)
			{
				void_internal_ArgList_next_var_void.Invoke(&@this->args_cur);
				@this->args_index++;
			}
		}
	}
}
