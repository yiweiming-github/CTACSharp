/**
* @author 寿贺飞
* @company 恒生电子股份有限公司
* @file HSStruct.h
* @brief 定义了接口使用的业务数据结构
* @date    20170927
*/
#ifndef _HS_API_STRUCT_H_
#define _HS_API_STRUCT_H_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "./HSDataType.h"
#pragma pack(push,4)
struct CHSRspInfoField
{
    /// 错误代码
    HSErrorID                ErrorID;
    /// 错误提示
    HSErrorMsg               ErrorMsg;
};

///客户登录
struct CHSReqUserLoginField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 密码
    HSPassword                    Password;
    /// 投资者端应用类别
    HSUserApplicationType             UserApplicationType;
    /// 投资者端应用信息
    HSUserApplicationInfo         UserApplicationInfo;
    /// 投资者Mac地址
    HSMacAddress                  MacAddress;
    /// 投资者IP地址
    HSIPAddress                   IPAddress;
};
///客户登录应答
struct CHSRspUserLoginField
{
    /// 营业部号
    HSNum                         BranchID;
    /// 账号
    HSAccountID                   AccountID;
    /// 投资者姓名
    HSUserName                    UserName;
    /// 交易日
    HSDate                        TradingDay;
    /// 上个交易日
    HSDate                        PreTradingDay;
    /// 账单确认标志
    HSBillConfirmFlag             BillConfirmFlag;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 投资者端应用类别
    HSUserApplicationType         UserApplicationType;
    /// 投资者端应用信息
    HSUserApplicationInfo         UserApplicationInfo;
};

///密码更改
struct CHSReqUserPasswordUpdateField
{
    /// 密码类型
    HSPasswordType                PasswordType;
    /// 密码
    HSPassword                    Password;
    /// 新密码
    HSPassword                    NewPassword;
};
///密码更改应答
struct CHSRspUserPasswordUpdateField
{
};

///报单录入
struct CHSReqOrderInsertField
{
    /// 报单引用
    HSRef                         OrderRef;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 开平标志
    HSOffsetFlag                  OffsetFlag;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单价格
    HSPrice                       OrderPrice;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 报单指令
    HSOrderCommand                OrderCommand;
    /// 最小成交量
    HSVolume                      MinVolume;
    /// 止损止盈价
    HSPrice                       SpringPrice;
    /// 互换标志
    HSSwapOrderFlag               SwapOrderFlag;
};
///报单录入应答
struct CHSRspOrderInsertField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 报单编码
    HSOrderSysID                  OrderSysID;
    /// 经纪公司报单编码
    HSBrokerOrderID               BrokerOrderID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 报单引用
    HSRef                         OrderRef;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 开平标志
    HSOffsetFlag                  OffsetFlag;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单价格
    HSPrice                       OrderPrice;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 报单指令
    HSOrderCommand                OrderCommand;
    /// 报单时间
    HSTime                        InsertTime;
    /// 最小成交量
    HSVolume                      MinVolume;
    /// 止损止盈价
    HSPrice                       SpringPrice;
    /// 互换标志
    HSSwapOrderFlag               SwapOrderFlag;
};

///撤单
struct CHSReqOrderActionField
{
    /// 报单编码
    HSOrderSysID                  OrderSysID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 报单引用
    HSRef                         OrderRef;
};
///撤单应答
struct CHSRspOrderActionField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 报单编码
    HSOrderSysID                  OrderSysID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 报单引用
    HSRef                         OrderRef;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 报单时间
    HSTime                        InsertTime;
};

///行权录入
struct CHSReqExerciseOrderInsertField
{
    /// 行权引用
    HSRef                         ExerciseRef;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 行权方式
    HSExerciseType                ExerciseType;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
};
///行权录入应答
struct CHSRspExerciseOrderInsertField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 行权报单编码
    HSOrderSysID                  ExerciseOrderSysID;
    /// 行权引用
    HSRef                         ExerciseRef;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 行权数量
    HSVolume                      OrderVolume;
    /// 行权方式
    HSExerciseType                ExerciseType;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 报单时间
    HSTime                        InsertTime;
};

///行权撤单
struct CHSReqExerciseOrderActionField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 行权报单编码
    HSOrderSysID                  ExerciseOrderSysID;
    /// 行权引用
    HSRef                         ExerciseRef;
    /// 会话编码
    HSSessionID                   SessionID;
};
///行权撤单应答
struct CHSRspExerciseOrderActionField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 行权报单编码
    HSOrderSysID                  ExerciseOrderSysID;
    /// 行权引用
    HSRef                         ExerciseRef;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
};

///锁定录入
struct CHSReqLockInsertField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 锁定类型
    HSLockType                    LockType;
    /// 报单数量
    HSVolume                      OrderVolume;
};
///锁定录入应答
struct CHSRspLockInsertField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 锁定报单编码
    HSOrderSysID                  LockOrderSysID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 锁定类型
    HSLockType                    LockType;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 标的物交易账号
    HSAccountID                   UnderlyingAccountID;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 报单时间
    HSTime                        InsertTime;
};

///询价录入
struct CHSReqForQuoteInsertField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
};
///询价录入应答
struct CHSRspForQuoteInsertField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
};

///申请组合录入
struct CHSReqCombActionInsertField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 组合策略编码
    HSCombStrategyID              CombStrategyID;
    /// 组合持仓编码
    HSCombPositionID              CombPositionID;
    /// 组合指令方向
    HSCombDirection               CombDirection;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
};
///申请组合录入应答
struct CHSRspCombActionInsertField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 组合报单编码
    HSOrderSysID                  CombOrderSysID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 组合策略编码
    HSCombStrategyID              CombStrategyID;
    /// 组合持仓编码
    HSCombPositionID              CombPositionID;
    /// 组合指令方向
    HSCombDirection               CombDirection;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 报单时间
    HSTime                        InsertTime;
};

///最大报单数量获取
struct CHSReqQueryMaxOrderVolumeField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 报单指令
    HSOrderCommand                OrderCommand;
    /// 买卖方向
    HSDirection                   Direction;
    /// 开平标志
    HSOffsetFlag                  OffsetFlag;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单价格
    HSPrice                       OrderPrice;
};
///最大报单数量获取应答
struct CHSRspQueryMaxOrderVolumeField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 最大报单量
    HSVolume                      MaxOrderVolume;
    /// 单笔最大报单量
    HSVolume                      MaxOrderVolumeUnit;
};

///可锁定数量获取
struct CHSReqQueryLockVolumeField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 锁定类型
    HSLockType                    LockType;
};
///可锁定数量获取应答
struct CHSRspQueryLockVolumeField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 锁定类型
    HSLockType                    LockType;
    /// 可用持仓数量
    HSVolume                      AvailablePositionVolume;
};

///可行权数量获取
struct CHSReqQueryExerciseVolumeField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
};
///可行权数量获取应答
struct CHSRspQueryExerciseVolumeField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 最大报单量
    HSVolume                      MaxOrderVolumeUnit;
};

///持仓汇总查询
struct CHSReqQryPositionField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
};
///持仓汇总查询应答
struct CHSRspQryPositionField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 上日持仓数量
    HSVolume                      YdPositionVolume;
    /// 持仓数量
    HSVolume                      PositionVolume;
    /// 今日持仓数量
    HSVolume                      TodayPositionVolume;
    /// 可用持仓数量
    HSVolume                      AvailablePositionVolume;
    /// 今日可用持仓数量
    HSVolume                      TodayAvailablePositionVolume;
    /// 持仓保证金
    HSBalance                     PositionMargin;
    /// 权利金
    HSBalance                     Premium;
    /// 手续费
    HSBalance                     Commission;
    /// 冻结数量
    HSVolume                      FrozenVolume;
    /// 组合数量
    HSVolume                      CombVolume;
    /// 组合冻结数量
    HSVolume                      CombFrozenVolume;
    /// 行权冻结数量
    HSVolume                      ExerciseFrozenVolume;
    /// 冻结保证金
    HSBalance                     FrozenMargin;
    /// 冻结权利金
    HSBalance                     FrozenPremium;
    /// 冻结书续费
    HSBalance                     FrozenCommission;
    /// 开仓量
    HSVolume                      OpenVolume;
    /// 平仓量
    HSVolume                      CloseVolume;
    /// 开仓金额
    HSBalance                     OpenBalance;
    /// 平仓金额
    HSBalance                     CloseBalance;
    /// 持仓均价
    HSPrice                       PositionAveragePrice;
    /// 持仓成本
    HSBalance                     PositionCost;
    /// 持仓盈亏
    HSBalance                     PositionProfit;
    /// 平仓盈亏
    HSBalance                     CloseProfit;
    /// 持仓盯市均价
    HSBalance                     PositionAveragePriceByDate;
    /// 持仓盯市盈亏
    HSBalance                     PositionProfitByDate;
    /// 平仓盯市盈亏
    HSBalance                     CloseProfitByDate;
    /// 期权市值
    HSBalance                     OptionsMarketValue;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
};

///资金账户查询
struct CHSReqQryTradingAccountField
{
};
///资金账户查询应答
struct CHSRspQryTradingAccountField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 上日余额
    HSBalance                     YdBalance;
    /// 上日持仓保证金
    HSBalance                     YdPositionMargin;
    /// 上日资金权益
    HSBalance                     YdFundEquity;
    /// 资金权益
    HSBalance                     FundEquity;
    /// 期权市值
    HSBalance                     OptionsMarketValue;
    /// 总权益
    HSBalance                     Equity;
    /// 可用资金
    HSBalance                     AvailableBalance;
    /// 可取资金
    HSBalance                     WithdrawBalance;
    /// 保证金
    HSBalance                     Margin;
    /// 冻结保证金
    HSBalance                     FrozenMargin;
    /// 风险度
    HSRiskDegree                  RiskDegree;
    /// 权利金
    HSBalance                     Premium;
    /// 冻结权利金
    HSBalance                     FrozenPremium;
    /// 手续费
    HSBalance                     Commission;
    /// 冻结手续费
    HSBalance                     FrozenCommission;
    /// 平仓盈亏
    HSBalance                     CloseProfit;
    /// 持仓盈亏
    HSBalance                     PositionProfit;
    /// 平仓盯市盈亏
    HSBalance                     CloseProfitByDate;
    /// 持仓盯市盈亏
    HSBalance                     PositionProfitByDate;
    /// 转入金额
    HSBalance                     Deposit;
    /// 转出金额
    HSBalance                     Withdraw;
    /// 货币质押金额
    HSBalance                     FundMortgage;
    /// 仓单质押金额
    HSBalance                     WarrantMortgage;
    /// 冻结资金
    HSBalance                     FrozenBalance;
    /// 解冻资金
    HSBalance                     UnFrozenBalance;
};

///报单查询
struct CHSReqQryOrderField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 报单编码
    HSOrderSysID                  OrderSysID;
};
///报单信息
struct CHSOrderField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 报单编码
    HSOrderSysID                  OrderSysID;
    /// 经纪公司报单编码
    HSBrokerOrderID               BrokerOrderID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 报单引用
    HSRef                         OrderRef;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 开平标志
    HSOffsetFlag                  OffsetFlag;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单价格
    HSPrice                       OrderPrice;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 成交数量
    HSVolume                      TradeVolume;
    /// 撤单数量
    HSVolume                      CancelVolume;
    /// 成交价格
    HSPrice                       TradePrice;
    /// 交易日
    HSDate                        TradingDay;
    /// 报单日期
    HSDate                        InsertDate;
    /// 报单时间
    HSTime                        InsertTime;
    /// 申报时间
    HSTime                        ReportTime;
    /// 报单指令
    HSOrderCommand                OrderCommand;
    /// 最小成交量
    HSVolume                      MinVolume;
    /// 止损止盈价
    HSPrice                       SpringPrice;
    /// 互换标志
    HSSwapOrderFlag               SwapOrderFlag;
    /// 强平原因
    HSForceCloseReason            ForceCloseReason;
    /// 错误信息
    HSErrorMsg                    ErrorMsg;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 报单发起方
    HSOrderSource                 OrderSource;
};

///成交查询
struct CHSReqQryTradeField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
};
///成交信息
struct CHSTradeField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 成交编码
    HSTradeID                     TradeID;
    /// 报单编码
    HSOrderSysID                  OrderSysID;
    /// 经纪公司报单编码
    HSBrokerOrderID               BrokerOrderID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 报单引用
    HSRef                         OrderRef;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 开平标志
    HSOffsetFlag                  OffsetFlag;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 成交数量
    HSVolume                      TradeVolume;
    /// 成交价格
    HSPrice                       TradePrice;
    /// 交易日
    HSDate                        TradingDay;
    /// 成交时间
    HSTime                        TradeTime;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
};

///行权查询
struct CHSReqQryExerciseField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 行权报单编码
    HSOrderSysID                  ExerciseOrderSysID;
};
///行权信息
struct CHSExerciseField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 行权报单编码
    HSOrderSysID                  ExerciseOrderSysID;
    /// 会话编码
    HSSessionID                   SessionID;
    /// 行权引用
    HSRef                         ExerciseRef;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 行权方式
    HSExerciseType                ExerciseType;
    /// 行权数量
    HSVolume                      OrderVolume;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 报单日期
    HSDate                        InsertDate;
    /// 报单时间
    HSTime                        InsertTime;
    /// 错误信息
    HSErrorMsg                    ErrorMsg;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 报单发起方
    HSOrderSource                 OrderSource;
};

///锁定查询
struct CHSReqQryLockField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 锁定报单编码
    HSOrderSysID                  LockOrderSysID;
};
///锁定信息
struct CHSLockField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 锁定报单编码
    HSOrderSysID                  LockOrderSysID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 锁定类型
    HSLockType                    LockType;
    /// 锁定数量
    HSVolume                      OrderVolume;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 交易日
    HSDate                        TradingDay;
    /// 锁定时间
    HSTime                        InsertTime;
    /// 错误信息
    HSErrorMsg                    ErrorMsg;
    /// 报单发起方
    HSOrderSource                 OrderSource;
};

///申请组合查询
struct CHSReqQryCombActionField
{
    /// 组合报单编码
    HSOrderSysID                  CombOrderSysID;
};
///申请组合信息
struct CHSCombActionField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 组合报单编码
    HSOrderSysID                  CombOrderSysID;
    /// 组合持仓编码
    HSCombPositionID              CombPositionID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 组合策略编码
    HSCombStrategyID              CombStrategyID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 组合指令方向
    HSCombDirection               CombDirection;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 报单数量
    HSVolume                      OrderVolume;
    /// 报单状态
    HSOrderStatus                 OrderStatus;
    /// 交易日
    HSDate                        TradingDay;
    /// 报单日期
    HSDate                        InsertDate;
    /// 报单时间
    HSTime                        InsertTime;
    /// 错误信息
    HSErrorMsg                    ErrorMsg;
    /// 报单发起方
    HSOrderSource                 OrderSource;
};

///组合持仓明细查询
struct CHSReqQryPositionCombineDetailField
{
};
///组合持仓明细查询应答
struct CHSRspQryPositionCombineDetailField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 组合持仓编码
    HSCombPositionID              CombPositionID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 组合策略编码
    HSCombStrategyID              CombStrategyID;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 买卖方向
    HSDirection                   Direction;
    /// 上日持仓数量
    HSVolume                      YdPositionVolume;
    /// 可用持仓数量
    HSVolume                      AvailablePositionVolume;
    /// 组合汇总数量
    HSVolume                      TotalCombVolume;
    /// 拆分汇总数量
    HSVolume                      TotalSplitVolume;
    /// 持仓保证金
    HSBalance                     PositionMargin;
    /// 开仓日期
    HSDate                        OpenDate;
};

///合约信息查询
struct CHSReqQryInstrumentField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
};
///合约信息查询应答
struct CHSRspQryInstrumentField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 合约名称
    HSInstrumentName              InstrumentName;
    /// 合约英文名称
    HSInstrumentEngName           InstrumentEngName;
    /// 合约品种编码
    HSProductID                   ProductID;
    /// 产品类型
    HSProductType                 ProductType;
    /// 市价单最大报单量
    HSVolume                      MaxMarketOrderVolume;
    /// 市价单最小报单量
    HSVolume                      MinMarketOrderVolume;
    /// 限价单最大报单量
    HSVolume                      MaxLimitOrderVolume;
    /// 限价单最小报单量
    HSVolume                      MinLimitOrderVolume;
    /// 合约数量乘数
    HSVolume                      VolumeMultiple;
    /// 最小变动价位
    HSPrice                       PriceTick;
    /// 是否使用大额单边保证金算法
    HSMaxMarginSideAlgorithm      MaxMarginSideAlgorithm;
    /// 大额单边保证金优惠品种
    HSMaxMarginSideProductID      MaxMarginSideProductID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 行权价
    HSPrice                       ExercisePrice;
    /// 期权类型
    HSOptionsType                 OptionsType;
    /// 交易标志
    HSTradingFlag                 TradingFlag;
    /// 上市日期
    HSDate                        MarketDate;
    /// 到期日
    HSDate                        ExpireDate;
    /// 行权开始日期
    HSDate                        BeginExerciseDate;
    /// 行权截至日期
    HSDate                        EndExerciseDate;
    /// 开始交割日
    HSDate                        BeginDeliveryDate;
    /// 结束交割日
    HSDate                        EndDeliveryDate;
};

///备兑缺口查询
struct CHSReqQryCoveredShortField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
};
///备兑缺口查询应答
struct CHSRspQryCoveredShortField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 备兑锁定数量
    HSVolume                      CoveredLockVolume;
    /// 备兑缺口数量
    HSVolume                      CoveredShortVolume;
    /// 备兑预估缺口数量
    HSVolume                      CoveredEstimateShortVolume;
    /// 提示信息
    HSNotifyMsg                   NotifyMsg;
};

///行权指派查询
struct CHSReqQryExerciseAssignField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 持仓类型
    HSPositionType                PositionType;
};
///行权指派查询应答
struct CHSRspQryExerciseAssignField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 持仓类型
    HSPositionType                PositionType;
    /// 期权类型
    HSOptionsType                 OptionsType;
    /// 行权价
    HSPrice                       ExercisePrice;
    /// 行权数量
    HSVolume                      ExerciseVolume;
    /// 交割数量
    HSVolume                      DeliveryVolume;
    /// 行权冻结资金
    HSBalance                     ExerciseFrozenBalance;
    /// 结算金额
    HSBalance                      SettlementBalance;
};

///银行转账
struct CHSReqTransferField
{
    /// 银行代码
    HSBankID                      BankID;
    /// 转账类型
    HSTransferType                TransferType;
    /// 发生金额
    HSBalance                     OccurBalance;
    /// 资金密码
    HSPassword                    FundPassword;
    /// 银行密码
    HSPassword                    BankPassword;
};
///银行转账应答
struct CHSRspTransferField
{
    /// 转账流水
    HSNum                         TransferSerialID;
};

///银行转账查询
struct CHSReqQryTransferField
{
    /// 银行代码
    HSBankID                      BankID;
    /// 转账流水
    HSNum                         TransferSerialID;
};
///银行转账查询应答
struct CHSRspQryTransferField
{
    /// 转账流水
    HSNum                         TransferSerialID;
    /// 银行代码
    HSBankID                      BankID;
    /// 银行名称
    HSBankName                    BankName;
    /// 业务名称
    HSBusinessName                BusinessName;
    /// 发生金额
    HSBalance                     OccurBalance;
    /// 转账时间
    HSTime                        TransferTime;
    /// 转账状态
    HSTransferStatus              TransferStatus;
    /// 转账发起方
    HSTransferSource              TransferSource;
    /// 备注
    HSRemarks                     Remarks;
};

///银行余额查询
struct CHSReqQueryBankBalanceField
{
    /// 银行代码
    HSBankID                      BankID;
    /// 资金密码
    HSPassword                    FundPassword;
    /// 银行密码
    HSPassword                    BankPassword;
};
///银行余额查询应答
struct CHSRspQueryBankBalanceField
{
    /// 转账流水
    HSNum                         TransferSerialID;
};

///银行账户查询
struct CHSReqQueryBankAccountField
{
    /// 银行代码
    HSBankID                      BankID;
};
///银行账户查询应答
struct CHSRspQueryBankAccountField
{
    /// 银行代码
    HSBankID                      BankID;
    /// 银行名称
    HSBankName                    BankName;
    /// 银行账号
    HSBankAccountID               BankAccountID;
};

///客户账单查询
struct CHSReqQueryBillContentField
{
    /// 开始日期
    HSDate                        BeginDate;
    /// 结束日期
    HSDate                        EndDate;
};
///客户账单查询应答
struct CHSRspQueryBillContentField
{
    /// 账单内容
    HSBillContent                 BillContent;
};

///客户账单确认
struct CHSReqBillConfirmField
{
};
///客户账单确认应答
struct CHSRspBillConfirmField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 账单已确认标志
    HSBillConfirmStatus           BillConfirmStatus;
};

///保证金查询
struct CHSReqQryMarginField
{
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
};
///保证金查询应答
struct CHSRspQryMarginField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 多头保证金率
    HSRate                        LongMarginRatio;
    /// 多头保证金
    HSBalance                     LongMargin;
    /// 空头保证金率
    HSRate                        ShortMarginRatio;
    /// 空头保证金
    HSBalance                     ShortMargin;
};

///手续费查询
struct CHSReqQryCommissionField
{
    /// 产品类型
    HSProductType                 ProductType;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
};
///手续费查询应答
struct CHSRspQryCommissionField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 产品类型
    HSProductType                 ProductType;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 期权对应的标的合约代码
    HSInstrumentID                UnderlyingInstrID;
    /// 多头开仓手续费率
    HSRate                        LongOpenCommissionRatio;
    /// 多头开仓手续费
    HSBalance                     LongOpenCommission;
    /// 多头平仓手续费率
    HSRate                        LongCloseCommissionRatio;
    /// 多头平仓手续费
    HSBalance                     LongCloseCommission;
    /// 多头平今手续费率
    HSRate                        LongCloseTodayCommissionRatio;
    /// 多头平今手续费
    HSBalance                     LongCloseTodayCommission;
    /// 空头开仓手续费率
    HSRate                        ShortOpenCommissionRatio;
    /// 空头开仓手续费
    HSBalance                     ShortOpenCommission;
    /// 空头平仓手续费率
    HSRate                        ShortCloseCommissionRatio;
    /// 空头平仓手续费
    HSBalance                     ShortCloseCommission;
    /// 空头平今手续费率
    HSRate                        ShortCloseTodayCommissionRatio;
    /// 空头平今手续费
    HSBalance                     ShortCloseTodayCommission;
    /// 行权手续费率
    HSRate                        ExerciseCommissionRatio;
    /// 行权手续费
    HSBalance                     ExerciseCommission;
    /// 成交面值比例
    HSRate                        TradeValueRatio;
    /// 股票面值
    HSBalance                     StockValue;
};

///持仓明细查询
struct CHSReqQryPositionDetailField
{
};
///持仓明细查询应答
struct CHSRspQryPositionDetailField
{
    /// 账号
    HSAccountID                   AccountID;
    /// 成交编码
    HSTradeID                     TradeID;
    /// 开仓日期
    HSDate                        OpenDate;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 买卖方向
    HSDirection                   Direction;
    /// 投机/套保/备兑类型
    HSHedgeType                   HedgeType;
    /// 上日持仓数量
    HSVolume                      YdPositionVolume;
    /// 当前数量
    HSVolume                      CurrentPositionVolume;
    /// 成交数量
    HSVolume                      TradeVolume;
    /// 持仓价格
    HSPrice                       PositionPrice;
    /// 平仓盯市盈亏
    HSBalance                     CloseProfitByDate;
    /// 今日冻结数量
    HSVolume                      TodayFrozenVolume;
    /// 今日平仓数量
    HSVolume                      TodayCloseVolume;
    /// 套利持仓号
    HSArbitPositionID             ArbitragePositionID;
    /// 腿号
    HSLegID                       LegID;
};

///经纪公司配置参数查询
struct CHSReqQrySysConfigField
{
};
///经纪公司配置参数查询应答
struct CHSRspQrySysConfigField
{
    /// 配置编号
    HSConfigNo                    ConfigNo;
    /// 配置开关状态
    HSConfigValue                 ConfigValue;
};

/// 行情订阅，取消订阅请求
struct CHSReqDepthMarketDataField
{
    HSExchangeID                  ExchangeID;
    HSInstrumentID                InstrumentID;
};

///行情查询
struct CHSReqQryDepthMarketDataField
{
	/// 交易所代码
	HSExchangeID                  ExchangeID;
	/// 合约代码
	HSInstrumentID                InstrumentID;
};

///行情信息
struct CHSDepthMarketDataField
{
    /// 交易日
    HSDate                        TradingDay;
    /// 合约代码
    HSInstrumentID                InstrumentID;
    /// 交易所代码
    HSExchangeID                  ExchangeID;
    /// 最新价
    HSPrice                       LastPrice;
    /// 昨结算价
    HSPrice                       PreSettlementPrice;
    /// 昨收盘价
    HSPrice                       PreClosePrice;
    /// 开盘价
    HSPrice                       OpenPrice;
    /// 最高价
    HSPrice                       HighestPrice;
    /// 最低价
    HSPrice                       LowestPrice;
    /// 成交数量
    HSVolume                      TradeVolume;
    /// 成交金额
    HSBalance                     TradeBalance;
    /// 总持量
    HSVolume                      OpenInterest;
    /// 收盘价
    HSPrice                       ClosePrice;
    /// 结算价
    HSPrice                       SettlementPrice;
    /// 涨停板价
    HSPrice                       UpperLimitPrice;
    /// 跌停板价
    HSPrice                       LowerLimitPrice;
    /// 昨虚实度
    HSDelta                       PreDelta;
    /// 今虚实度
    HSDelta                       CurrDelta;
    /// 最后冻结更新时间
    HSTime                        UpdateTime;
    /// 申买价一
    HSPrice                       BidPrice1;
    /// 申买量一
    HSVolume                      BidVolume1;
    /// 申卖价一
    HSPrice                       AskPrice1;
    /// 申卖量一
    HSVolume                      AskVolume1;
    /// 申买价二
    HSPrice                       BidPrice2;
    /// 申买量二
    HSVolume                      BidVolume2;
    /// 申卖价二
    HSPrice                       AskPrice2;
    /// 申卖量二
    HSVolume                      AskVolume2;
    /// 申买价三
    HSPrice                       BidPrice3;
    /// 申买量三
    HSVolume                      BidVolume3;
    /// 申卖价三
    HSPrice                       AskPrice3;
    /// 申卖量三
    HSVolume                      AskVolume3;
    /// 申买价四
    HSPrice                       BidPrice4;
    /// 申买量四
    HSVolume                      BidVolume4;
    /// 申卖价四
    HSPrice                       AskPrice4;
    /// 申卖量四
    HSVolume                      AskVolume4;
    /// 申买价五
    HSPrice                       BidPrice5;
    /// 申买量五
    HSVolume                      BidVolume5;
    /// 申卖价五
    HSPrice                       AskPrice5;
    /// 申卖量五
    HSVolume                      AskVolume5;
    /// 平均价格
    HSPrice                       AveragePrice;
    /// 昨持仓量
    HSVolume                      PreOpenInterest;
    /// 交易所状态
    HSInstrumentTradeStatus       InstrumentTradeStatus ;
    /// 合约实时开仓限制
    HSOpenRestriction             OpenRestriction;
};


#pragma pack(pop)
#endif
